using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingVisualizer
{
    public partial class Form1 : Form
    {
        int[] dt = new int[20];
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Scramble();
        }

        private void Scramble()
        {
            for (int i = 0; i < dt.Length; i++)
                dt[i] = rand.Next();
            chart1.Series[0].Points.DataBindY(dt);
        }
        private void bubbleSort()
        {
            int aux;
            bool moved; //ESTA VARIABLE NOS SIRVE POR SI HAY QUE HACER VARIOS ACOMODAMIENTOS DEL MISMO VALOR
            do{
                moved = false;
                for (int i = 0; i < dt.Length - 1; i++) 
                    if (dt[i] > dt[i + 1]){ //COMPARA CADA VALOR CON SU VECINO PARA VER SI ESTA EN ORDEN CORRECTO
                        aux = dt[i + 1]; //SI ESTA DESORDENADO INTERCAMBIA LOS VALORES
                        dt[i + 1] = dt[i];
                        dt[i] = aux;
                        moved = true;
                        graphUpdate();
                    }
            } while (moved);
        }

        private void insertionSort()
        {
            int item, current;
            for (int i = 0; i < dt.Length; i++){ //LOOP DE TODOS LOS ITEMS
                item = dt[i];
                current = i;
                while(current > 0 && dt[current -1] > item){ //LOOP DE LOS ITEMS INFERIORES AL ACTUAL
                    dt[current] = dt[current - 1];
                    current--;
                    graphUpdate();
                }
                dt[current] = item;
            }
        }

        private void selectionSort()
        {
            int min, aux;
            for (int i = 0; i < dt.Length; i++){
                min = i;
                for (int j = i + 1; j < dt.Length; j++)
                    if (dt[min] > dt[j])
                        min = j;
                if(min != i){
                    aux = dt[min];
                    dt[min] = dt[i];
                    dt[i] = aux;
                }
                graphUpdate();
            }
        }

        public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
            graphUpdate();
        }

        public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }

        private void graphUpdate()
        {
            chart1.Series[0].Points.DataBindY(dt);
            chart1.Update();
            System.Threading.Thread.Sleep(4000 / dt.Length); //DELAY PARA QUE SEA MAS FACIL DE VISUALIZAR
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            labelStatus.Visible = true;
            labelStatus.Text = "Ordenamiento en Progreso";
            labelStatus.ForeColor = Color.Red;
            bubbleSort();
            labelStatus.Text = "Ordenamiento Completado";
            labelStatus.ForeColor = Color.White;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            labelStatus.Visible = true;
            labelStatus.Text = "Ordenamiento en Progreso";
            labelStatus.ForeColor = Color.Red;
            insertionSort();
            labelStatus.Text = "Ordenamiento Completado";
            labelStatus.ForeColor = Color.White;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            labelStatus.Visible = true;
            labelStatus.Text = "Ordenamiento en Progreso";
            labelStatus.ForeColor = Color.Red;
            selectionSort();
            labelStatus.Text = "Ordenamiento Completado";
            labelStatus.ForeColor = Color.White;
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            labelStatus.Visible = true;
            labelStatus.Text = "Ordenamiento en Progreso";
            labelStatus.ForeColor = Color.Red;
            SortMerge(dt, 0, dt.Length - 1);
            labelStatus.Text = "Ordenamiento Completado";
            labelStatus.ForeColor = Color.White;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelSuperior_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Scramble();
        }
    }
}
