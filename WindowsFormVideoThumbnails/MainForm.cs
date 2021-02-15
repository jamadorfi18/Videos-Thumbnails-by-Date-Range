using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormVideoThumbnails
{
    public partial class MainForm : Form
    {
        private const string DATA_URI = "data.xml";
        private const string Name = "directoryFolder";
        private FileInfo[] _filesInfo = default;
        private string _directoryName = default;
        private XDocument _xmlData = default;

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _xmlData = XDocument.Load(DATA_URI);
            }
            catch (Exception)
            {
                var xmlDocument = new XDocument(new XElement(Name, ""));
                xmlDocument.Save(DATA_URI);
                _xmlData = XDocument.Load(DATA_URI);
            }
        }

        private void chooseFolderBtn_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.Description = "Seleccione la carpeta dónde se encuentren todas las grabaciones";
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.explorerTextBox.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void listFilesBtn_Click(object sender, EventArgs e)
        {
            if (this.explorerTextBox.Text.Any())
            {
                ClearFiles();
                ListFiles();
            }
            else
            {
                MessageBox.Show("Por favor selecciona una carpeta para encontrar los videos dentro de ella.");
            }
        }

        private void ClearFiles()
        {
            this.filesListBox.Items.Clear();
            this._filesInfo = default;
        }

        private void ListFiles()
        {
            var startDate = startDateTimePicker.Value.Date;
            var endDate = endDateTimePicker.Value.Date.AddDays(1).AddTicks(-1);
            this._directoryName = String.Format("{0} - {1}", startDate.ToString("dd-MM-yyyy"), endDate.ToString("dd-MM-yyyy"));
            var directoyInfo = new DirectoryInfo(this.explorerTextBox.Text);
            this._filesInfo = directoyInfo.GetFiles("*.mp4", SearchOption.AllDirectories)
                                        .Where(x => x.CreationTime > startDate && x.CreationTime < endDate).ToArray();

            if (this._filesInfo.Any())
            {
                this.filesListBox.BeginUpdate();
                foreach (var fileInfo in _filesInfo)
                {
                    this.filesListBox.Items.Add(String.Format("{0} - {1}", fileInfo.Name, fileInfo.CreationTime.ToString("dddd, dd MMMM yyyy hh:mm tt")));

                }
                this.filesListBox.EndUpdate();
            }
            else
            {
                MessageBox.Show("No se encontró ningún video con las fechas y carpeta seleccionada.");
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (this._filesInfo != default && this._filesInfo.Any())
            {
                var fmmpeg = new NReco.VideoConverter.FFMpegConverter();
                this.folderBrowserDialog.Description = "Seleccione donde quiere guardar las imágenes de los videos";
                if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    var path = this.folderBrowserDialog.SelectedPath;
                    DirectoryInfo directoryInfo = default;
                    foreach (var fileInfo in this._filesInfo)
                    {
                        directoryInfo = Directory.CreateDirectory(String.Format("{0}/{1}", path, _directoryName));
                        fmmpeg.GetVideoThumbnail(fileInfo.FullName, String.Format("{0}/{1}.jpg", directoryInfo.FullName, fileInfo.Name.Replace(".mp4", String.Empty)), 2f);
                    }

                    if (MessageBox.Show(String.Format("Imágenes creadas con éxito en {0}", directoryInfo.FullName)) == DialogResult.OK)
                    {
                        Process.Start(directoryInfo.FullName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione carpeta de las grabaciones, fechas y click en listar videos, se necesita al menos un video para poder obtener sus imágenes");
            }
        }
    }
}
