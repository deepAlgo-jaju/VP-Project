using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoConferencing
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// TabPage Menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //ToolStripMenuItem Contacts, ToolStripMenu SubItem Add
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_tabPage_Menu_Delete.Visible = false;
            panel_tabPage_Menu_View.Visible = false;
            panel_tabPage_Menu_Add.Visible = true;
        }

        // ToolStripMenuItem Contacts, ToolStripMenu SubItem View

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_tabPage_Menu_Delete.Visible = false;
            panel_tabPage_Menu_Add.Visible = false;
            panel_tabPage_Menu_View.Visible = true;
        }

        // ToolStripMenuItem Contacts, ToolStripMenu SubItem Delete

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_tabPage_Menu_View.Visible = false;
            panel_tabPage_Menu_Add.Visible = false;
            panel_tabPage_Menu_Delete.Visible = true;
        }
    }
}
