using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormLista<T>: Form where T: Model {

        private List<T> Lista { get; set; }

        public FormLista(List<T> lista, String[] columns) {
            InitializeComponent();
            Lista = lista;
            for (int i = 0; i < columns.Length; i++) {
                listView.Columns.Add(new ColumnHeader { DisplayIndex = i, Text = columns[i] });
            }
            Populate();
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            Int32 id = Lista.Count > 0? Lista.Max().Id + 1: 1;
            Type clazz = Registro.GetRegistro(typeof(T).Name);
            ConstructorInfo constructor = clazz.GetConstructor(new Type[] { typeof(T) });
            FormCadastro formCadastro = (FormCadastro)constructor.Invoke(new Object[] { null });
            if (formCadastro.ShowDialog(this) == DialogResult.OK) {
                T model = (T)Activator.CreateInstance(typeof(T), true);
                formCadastro.UpdateModel(model);
                model.Id = id;
                Lista.Add(model);
                Repository.Save();
                Populate();
                formCadastro.Dispose();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (listView.SelectedItems.Count == 0) {
                return;
            }
            foreach (T model in Lista) {
                if (listView.SelectedItems[0].Tag.Equals(model)) {
                    Type clazz = Registro.GetRegistro(typeof(T).Name);
                    ConstructorInfo constructor = clazz.GetConstructor(new Type[] { typeof(T) });
                    FormCadastro frmCadastro = (FormCadastro)constructor.Invoke(new Object[] { model });
                    if (frmCadastro.ShowDialog(this) == DialogResult.OK) {
                        frmCadastro.UpdateModel(model);
                        frmCadastro.Dispose();
                        Repository.Save();
                        Populate();
                        break;
                    }
                }
            }
        }
         
        private void Populate() {
            listView.Items.Clear();
            foreach (T item in Lista) {
                listView.Items.Add(new ListViewItem(item.GetValues()) { Tag = item });
            }
        }
    }
}