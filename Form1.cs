using linked_list;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniStacksAndQueuse
{
    public partial class btnScreeningComplete : Form
    {


        int counter = 1;

        public btnScreeningComplete()
        {
            InitializeComponent();

            populateFirstQue();
            updateFirstQueList();
        }


        private void updateFirstQueList()
        {
            lbFirstQue.Items.Clear();

            foreach (var item in GenStackQue.firstQue.GetNodes())
            {
                lbFirstQue.Items.Add(item.NodeData.ToString());
            }
        }

        private void populateFirstQue()
        {
            GenStackQue.firstQue.Push( new GenNode<Person>(new Person("Bob", "Bobber", 143241234)));
            GenStackQue.firstQue.Push( new GenNode<Person>(new Person("Mike", "Micheal", 346565463)));
            GenStackQue.firstQue.Push( new GenNode<Person>(new Person("Jim", "Jimmer", 346565463)));
            GenStackQue.firstQue.Push( new GenNode<Person>(new Person("Sarah", "Summer", 346565463)));

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            counter++;
            GenStackQue.firstQue.Push(new GenNode<Person>(new Person("Person " + counter , "Surname " + counter, 143241234)));

            updateFirstQueList();

        }

        private void btnNextFirstQue_Click(object sender, EventArgs e)
        {

        }
    }
}
