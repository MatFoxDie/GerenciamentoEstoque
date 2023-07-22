using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoEstoque
{
    public partial class StockWise : Form
    {
        public StockWise()
        {
            InitializeComponent();
        }

        private void btnResumoEstoque_Click(object sender, EventArgs e)
        {

        }

        private void StockWise_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customizeDesign()
        {
            panelPainelControleSubmenu.Visible = false;
            panelGerenciamentoProdutosSubmenu.Visible = false;
            panelGerenciamentoFornecedoresSubmenu.Visible = false;
            panelEntradasSaidasSubmenu.Visible = false;
        }

        private void HideSubmenu()
        {
            if(panelPainelControleSubmenu.Visible)
                panelPainelControleSubmenu.Visible=false;

            if (panelGerenciamentoProdutosSubmenu.Visible)
                panelGerenciamentoProdutosSubmenu.Visible = false;

            if(panelGerenciamentoFornecedoresSubmenu.Visible)
                panelGerenciamentoFornecedoresSubmenu.Visible = false;

            if (panelEntradasSaidasSubmenu.Visible)
                panelEntradasSaidasSubmenu.Visible = false;

        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
                HideSubmenu();

        }

        private void btnControlPanel_Click(object sender, EventArgs e)
        {
            showSubmenu(panelPainelControleSubmenu);
        }

        private void btnGerenciamentoProdutos_Click(object sender, EventArgs e)
        {
            showSubmenu(panelGerenciamentoProdutosSubmenu);
        }

        private void btnGerenciamentoFornecedores_Click(object sender, EventArgs e)
        {
            showSubmenu(panelGerenciamentoFornecedoresSubmenu);
        }

        private void btnEntradasSaidas_Click(object sender, EventArgs e)
        {
            showSubmenu(panelEntradasSaidasSubmenu);
        }

        private void btnListagemProdutos_Click(object sender, EventArgs e)
        {
            //Codigo
            openChildForm(new Produtos());
            //

            HideSubmenu();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
