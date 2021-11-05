using Project.BLL.DesignPatterns.Genericrepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             _crep = new CategoryRepository();
        }
        CategoryRepository _crep;

        void CategoryList()
        {
            lstSonuc.DataSource = _crep.GetAll();
        }

        void AktifleriGetir()
        {
            lstSonuc.DataSource = _crep.GetActives();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _crep.Add(new ENTITIES.Models.Category { CategoryName = txtCategoryName.Text });
            AktifleriGetir();
        }

        Category SelectCategory()
        {
            return lstSonuc.SelectedItem as Category;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Category c = SelectCategory();
            c.CategoryName = txtCategoryName.Text;
            _crep.Update(c);
            AktifleriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Category c = SelectCategory();
            _crep.Delete(c);
            AktifleriGetir();

        }

        private void btnHepsi_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnPasifler_Click(object sender, EventArgs e)
        {
            lstSonuc.DataSource = _crep.GetPassive();
        }

        private void btnGuncellenenler_Click(object sender, EventArgs e)
        {
            lstSonuc.DataSource = _crep.GetModifieds();
        }

        private void btnAktifler_Click(object sender, EventArgs e)
        {
            AktifleriGetir();
        }
    }
}
