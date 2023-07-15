using System.Data;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace SqlApplication
{
   public partial class Form1 : Form
   {
      UseDb useDb = new UseDb();
      Parameter pm = new Parameter();

      public Form1()
      {
         InitializeComponent();
      }

      private void BtnCreate_Click(object sender, EventArgs e)
      {

         if (useDb.CreateDatabase() & useDb.FillTable())
         {
            lbl1.Text = "table created";
            lbl1.ForeColor = System.Drawing.Color.Black;
            lbl1.Visible = true;
            lbl2.Text = "filled up with data";
            lbl2.Visible = true;
            btnCreate.Visible = false;

         }
         else
         {
            lbl1.Text = "table not created";
            lbl1.ForeColor = System.Drawing.Color.Red;
            lbl1.Visible = true;
            lbl2.Visible = false;
         }
      }

      private void BtnAddCar_Click(object sender, EventArgs e)
      {
         dgv.Visible = false;
         pictureBox1.Visible = false;
         panel1.Visible = true;
         btnDelete.Visible = false;
         lbl1.Visible = false;
         lbl2.Visible = false;
         lblId.Text = useDb.GetLastRecordId();

      }
      private void BtnAddExec_Click(object sender, EventArgs e)
      {
         String newManuf;
         String newModel;
         String newBuilt;
         newManuf = tbManuf.Text;
         newModel = tbModel.Text;
         newBuilt = tbBuilt.Text;
         useDb.AddCarExec(newManuf, newModel, newBuilt);
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         if (!(dgv.Rows.Count == 0))
         {
            String rowToDelete = dgv.CurrentRow.Cells[0].Value.ToString();
            useDb.DeleteCar(rowToDelete);
            useDb.GetData(dgv);
         }
         else
         {
            MessageBox.Show("Nothing to delete.");
         }

      }

      private void BtnShowData_Click(object sender, EventArgs e)
      {
         if (useDb.GetData(dgv))
         {

            lbl1.Visible = false;
            lbl2.Visible = false;
            btnCreate.Visible = false;
            pictureBox1.Visible = false;
            panel1.Visible = false;
            dgv.Visible = true;
            btnAddCar.Visible = true;
            btnDelete.Visible = true;
         }
         else
         {
            lbl1.Text = "Database not exists!";
            lbl1.ForeColor = System.Drawing.Color.Red;
            lbl1.Visible = true;
            btnCreate.Visible = true;
         }
      }

      private void BtnQuit_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void pictureBox1_Click(object sender, EventArgs e)
      {

      }

      private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
      {

      }
   }
}