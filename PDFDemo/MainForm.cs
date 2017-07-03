using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace PDFDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtDiretorio.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiretorio.Text))
            {
                MessageBox.Show("Informe um caminho de diretório");
                return;
            }
            else if (string.IsNullOrEmpty(txtFileName.Text))
            {
                MessageBox.Show("Iforme um nome para o arquivo");
                return;
            }
            else if (string.IsNullOrEmpty(txtContent.Text))
            {
                MessageBox.Show("O conteudo do arquivo está vazio");
                return;
            }

            try
            {
                PdfDocument pdf = new PdfDocument();
                PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
                graph.DrawString(txtContent.Text, font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                pdf.Save($"{txtDiretorio.Text}\\{txtFileName.Text}.pdf");
                Process.Start($"{txtDiretorio.Text}\\{txtFileName.Text}.pdf");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show($"Ocorreu um Erro: {exception.Message}");
                return;
            }

        }
    }
}