using AdvancoTask.XmlOperation;
using System;
using System.Windows.Forms;

namespace AdvancoTask
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        PersonelDal _personalDal = new PersonelDal();
        ExportXmlSerialize serializeObject = new ExportXmlSerialize();
        İmportXmlDeserialize deserializeObject = new İmportXmlDeserialize();

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPersonal();
            dgwPersonal.Columns["id"].Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxPersonalId.Text == "" || tbxSurname.Text == "" || tbxPersonalId.Text == "")
            {
                MessageBox.Show("Alanların Hepsini Doldurun!");
            }
            else
            {
                _personalDal.Add(new Personel
                {
                    Name = tbxName.Text,
                    Surname = tbxSurname.Text,
                    PersonalID = Convert.ToInt32(tbxPersonalId.Text),
                    HireDate = Convert.ToDateTime(tbxHireDate.Text)
                });
                MessageBox.Show("Added");
                LoadPersonal();
            }
            Clean();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _personalDal.Update(new Personel
            {
                id = Convert.ToInt32(dgwPersonal.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text.Trim(),
                Surname = tbxSurnameUpdate.Text.Trim(),
                PersonalID = Convert.ToInt32(tbxPersonalIdUpdate.Text.Trim()),
                HireDate = Convert.ToDateTime(tbxHireDateUpdate.Text.Trim())
            });
            LoadPersonal();
            MessageBox.Show("Updated");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                _personalDal.Delete(new Personel
                {
                    id = Convert.ToInt32(dgwPersonal.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Deleted");
                LoadPersonal();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btnXmlImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                deserializeObject.Deserialize(ofd.FileName);
                
                MessageBox.Show("Data Imported and Saved to SQL");
                LoadPersonal();
            }
        }
        private void btnXmlExp_Click_1(object sender, EventArgs e)
        {
            serializeObject.CreateXML();
            MessageBox.Show("Exported on Your Desktop!");
        }
        private void dgwPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwPersonal.CurrentRow.Cells[1].Value.ToString().Trim();
            tbxSurnameUpdate.Text = dgwPersonal.CurrentRow.Cells[2].Value.ToString().Trim();
            tbxPersonalIdUpdate.Text = dgwPersonal.CurrentRow.Cells[3].Value.ToString().Trim();
            tbxHireDateUpdate.Text = dgwPersonal.CurrentRow.Cells[4].Value.ToString().Trim();
        }
        private void LoadPersonal()
        {
            dgwPersonal.DataSource = _personalDal.GetAll();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;
            if (!string.IsNullOrEmpty(key))
            {
                dgwPersonal.DataSource = _personalDal.GetAll((p => p.Name.ToLower().Contains(tbxSearch.Text.ToLower())));
            }
            else
            {
                LoadPersonal();
            }

        }
        private void Clean()
        {
            tbxName.Text = "";
            tbxSurname.Text = "";
            tbxHireDate.Text = "";
            tbxPersonalId.Text = "";
        }
    }
}




