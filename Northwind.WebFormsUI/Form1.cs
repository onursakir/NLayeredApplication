﻿using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {

        private IProductService _productService;
        private ICategoryService _categoryService;
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryAdd.DataSource = _categoryService.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";
            
            cbxCategoryUpd.DataSource = _categoryService.GetAll();
            cbxCategoryUpd.DisplayMember = "CategoryName";
            cbxCategoryUpd.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }
            
        }

        private void tbxProduct_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProduct.Text))
                {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProduct.Text);
            }
            else
            {
                LoadProducts();
            }
              
            }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                ProductName = tbxProductNameAdd.Text,
                QuantityPerUnit = tbxQuantityPerUnitAdd.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                UnitsInStock = Convert.ToInt16(tbxStockAdd.Text)

            }) ;
            MessageBox.Show("Ürün Kaydedildi");
            LoadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cbxCategoryUpd.SelectedValue),
                ProductName = tbxProductNameUpd.Text,
                QuantityPerUnit = tbxQuantityUpd.Text,
                UnitPrice = Convert.ToDecimal(tbxPriceUpd.Text),
                UnitsInStock = Convert.ToInt16(tbxStockAmountUpd.Text)

            }) ;
            
            MessageBox.Show("Ürün güncellendi!");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxProductNameUpd.Text = row.Cells[1].Value.ToString();
            cbxCategoryUpd.SelectedValue = row.Cells[2].Value;
            tbxPriceUpd.Text = row.Cells[3].Value.ToString();
            tbxQuantityUpd.Text = row.Cells[4].Value.ToString();
            tbxStockAmountUpd.Text = row.Cells[5].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
               
            }
            
            MessageBox.Show("Ürün Silindi!");
            LoadProducts();

        }
    }
    }

