using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsServiceStationApp.Views.Forms
{
    public partial class DefaultRoleForm : Form, IDefaultRole
    {
        int curretrRowIndexForShow = -1;
        int curMouseOverRow = -1;
       
        const int IND_GRIDCELLS_ID = 1;
        const int IND_GRIDCELLS_ROWVERS = 2;

        int select = 0;
  
        public DefaultRoleForm()
        {
            InitializeComponent();
        }

        // интерфейсы
        #region IDefaultRole
        public int roleId_Integer { get; set; }
        public string NameSpeciality_Text 
        { 
            get => textBox1.Text; 
            set => textBox1.Text = value; 
        }
        public object roleList_Object
        {
            get => dataGridView1.DataSource; 
            set => dataGridView1.UniverseInvoke(() => dataGridView1.DataSource = value);
        }

        public byte[] roleRowVersion_ByteArray { get; set; }
        #endregion

        private async void AddStateElemAsync()
        {
            try
            {
                Presenters.DefaultRolePresenter rolePresenter = new Presenters.DefaultRolePresenter(this);
                await Task.Run(() => { rolePresenter.AddRoleElem(); });
                rolePresenter.GetDefaultRoleTable();
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private async void LoadTableAsync()
        {
            Presenters.DefaultRolePresenter rolePresenter = new Presenters.DefaultRolePresenter(this);
            await Task.Run(() => { rolePresenter.GetDefaultRoleTable(); });
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e) => dataGridView1.MouseDownSelectRow_UserOverride(e, ref curretrRowIndexForShow, ref curMouseOverRow);
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) => dataGridView1.RowPrePait_UserOverride(e);
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            curretrRowIndexForShow = e.RowIndex;
            dataGridView1.Rows[curretrRowIndexForShow].Selected = true;
        }

        private void DefaultRoleForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleBuffered(true);
            LoadTableAsync();
        }

        private async void UpdateRoleElemAsync()
        {
            if (curretrRowIndexForShow >= 0)
            {
                roleId_Integer = (int)dataGridView1.Rows[curretrRowIndexForShow].Cells[IND_GRIDCELLS_ID].Value;
                roleRowVersion_ByteArray = (byte[])dataGridView1.Rows[curretrRowIndexForShow].Cells[IND_GRIDCELLS_ROWVERS].Value;
                Presenters.DefaultRolePresenter rolePresenter = new Presenters.DefaultRolePresenter(this);
                await Task.Run(() => { rolePresenter.UpdateRole(); });
                rolePresenter.GetDefaultRoleTable(); // обновляю после добавления
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Выберите строку в таблице и повторите снова! Строка не выбрана!");
            }
        }

        private async void RemoveRoleElemAsync()
        {
            if (curretrRowIndexForShow >= 0 && dataGridView1.DataSource != null)
            {
                roleId_Integer = (int)dataGridView1.Rows[curretrRowIndexForShow].Cells[IND_GRIDCELLS_ID].Value;
                roleRowVersion_ByteArray = (byte[])dataGridView1.Rows[curretrRowIndexForShow].Cells[IND_GRIDCELLS_ROWVERS].Value;
                Presenters.DefaultRolePresenter rolePresenter = new Presenters.DefaultRolePresenter(this);
                await Task.Run(() => { rolePresenter.RemoveState(); });
                rolePresenter.GetDefaultRoleTable(); // обновляю после добавления
            }
            else
            {
                MessageBox.Show("Выберите строку в таблице и повторите снова! Строка не выбрана!");
            }
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // блокирую меню
            добавитьЗаписьToolStripMenuItem.Enabled = false;
            изменитьВыбраннуюЗаписьToolStripMenuItem.Enabled = false;
            удалитьВыбраннуюЗаписьToolStripMenuItem.Enabled = false;

            select = 1;
            panel1.Enabled = true;
        }

        private void изменитьВыбраннуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curretrRowIndexForShow >= 0)
            {
                textBox1.Text = dataGridView1.Rows[curretrRowIndexForShow].Cells[0].Value.ToString();

                // блокирую меню
                добавитьЗаписьToolStripMenuItem.Enabled = false;
                изменитьВыбраннуюЗаписьToolStripMenuItem.Enabled = false;
                удалитьВыбраннуюЗаписьToolStripMenuItem.Enabled = false;

                dataGridView1.Enabled = false;
                select = 2;
                panel1.Enabled = true;
            }
        }

        private void удалитьВыбраннуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curretrRowIndexForShow >= 0)
            {
                // блокирую меню
                добавитьЗаписьToolStripMenuItem.Enabled = false;
                изменитьВыбраннуюЗаписьToolStripMenuItem.Enabled = false;
                удалитьВыбраннуюЗаписьToolStripMenuItem.Enabled = false;
                RemoveRoleElemAsync(); // удаление
                panel1.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (select == 1) // если выбрано добавить
            {
                AddStateElemAsync();
            }
            if (select == 2) // редактирование
            {
                dataGridView1.Enabled = true;
                UpdateRoleElemAsync();
            }

            panel1.Enabled = false;
            // разблокирую меню
            добавитьЗаписьToolStripMenuItem.Enabled = true;
            изменитьВыбраннуюЗаписьToolStripMenuItem.Enabled = true;
            удалитьВыбраннуюЗаписьToolStripMenuItem.Enabled = true;

            //   dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel1.Enabled = false;
            // разблокирую меню
            добавитьЗаписьToolStripMenuItem.Enabled = true;
            изменитьВыбраннуюЗаписьToolStripMenuItem.Enabled = true;
            удалитьВыбраннуюЗаписьToolStripMenuItem.Enabled = true;

            //dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridView1.Enabled = true;
        }
    }
}
