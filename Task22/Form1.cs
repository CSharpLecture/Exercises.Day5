using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CsharpSolutions.Exercises.Task22
{
    public partial class Form1 : Form
    {
        //We globally store the two lists and the possible functions
        IEnumerable<Int32> a;
        IEnumerable<Int32> b;
        Dictionary<Operation, Func<IEnumerable<Int32>>> functions;

        public Form1()
        {
            //First initialization
            a = Enumerable.Empty<Int32>();
            b = Enumerable.Empty<Int32>();
            functions = new Dictionary<Operation, Func<IEnumerable<Int32>>>();
            InitializeComponent();
        }

        //When the form is loaded we want to setup the functions
        private void Form1_Load(object sender, EventArgs e)
        {
            AddFunction(Operation.Intersection, () => a.Intersect(b));
            AddFunction(Operation.Union, () => a.Union(b));
            AddFunction(Operation.Except, () => a.Except(b));
            AddFunction(Operation.SymmetricExcept, () => a.Union(b).Except(a.Intersect(b)));
            AddFunction(Operation.Square, () => a.Union(b).Select(m => m * m));
            AddFunction(Operation.SquareRoot, () => a.Union(b).Select(m => (int)Math.Sqrt(m)));
            AddFunction(Operation.Sum, () => new[] { a.Sum(), b.Sum() });
            AddFunction(Operation.Min, () => new[] { a.Min(), b.Min() });
            AddFunction(Operation.Max, () => new[] { a.Max(), b.Max() });
            operation.SelectedIndex = 0;
        }

        void AddFunction(Operation op, Func<IEnumerable<Int32>> f)
        {
            //Just add it to the dictionary of operations
            functions.Add(op, f);
            //And to the combobox
            operation.Items.Add(op);
        }

        private void operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If the operation changed we want to refresh the view
            RefreshOperation();
        }

        //Refreshing the view is just applying the function
        private void RefreshOperation()
        {
            var res = functions[(Operation)operation.SelectedItem]();

            result.Items.Clear();

            foreach (var item in res)
                result.Items.Add(item);
        }

        //Storing means trying to parse the list of numbers
        private void store_Click(object sender, EventArgs e)
        {
            int[] a;
            int[] b;

            try
            {
                //This is the simplest, yet not really well performing way
                a = listA.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(m => Int32.Parse(m)).ToArray();
            }
            catch
            {
                MessageBox.Show("The values stored in list A are invalid.");
                return;
            }

            try
            {
                b = listB.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(m => Int32.Parse(m)).ToArray();
            }
            catch
            {
                //We display an error message in case of an exception
                MessageBox.Show("The values stored in list B are invalid.");
                return;
            }

            this.a = a;
            this.b = b;
            //Refresh the view
            RefreshOperation();
        }
    }
}
