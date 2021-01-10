using System;
using System.Windows.Forms;
using System.Xml;

namespace FirmarXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"C:\";
                ofd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                ofd.FilterIndex =1;
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    DocumentXml.Text = ofd.FileName;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"C:\";
                ofd.Filter = "pfx files (*.pfx)|*.pfx|All files (*.*)|*.*";
                ofd.FilterIndex = 0;
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Certificado.Text = ofd.FileName;
                }
            }
        }

        public void reset()
        {
            DocumentXml.Text = "";
            Certificado.Text = "";
            Password.Text = "";
            DocumentXml.Focus();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FirmarXml firmarxml = new FirmarXml();
                XmlDocument xmlDocument_SinFirmar = new XmlDocument();
                //Ruta de Archivo xml
                XmlReader VariableName = XmlReader.Create(@""+DocumentXml.Text);
                xmlDocument_SinFirmar.Load(VariableName);
                //ruta por defecto en el proyecto E:\Libio Data\Proyectos\C#\Sunat\FirmarXml\FirmarXml\bin\Debug en mi caso
                firmarxml.FirmarDocumentXML(xmlDocument_SinFirmar, @""+Certificado.Text, Password.Text).Save("xml_firmado.xml");

                reset();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
