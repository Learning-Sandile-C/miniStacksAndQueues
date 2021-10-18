using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    class GenStackQueHelper<T>
    {
        private GenNode<T> headNode;
        private GenNode<T> tailNode;
        private int size = 0;

        public List<GenNode<T>> GetNodes()
        {
            List<GenNode<T>> tempNodes = new List<GenNode<T>>();

            GenNode<T> runner = headNode;

            for (int i = 0; i < size; i++)
            {
                tempNodes.Add(runner);

                runner = runner.NextNode;
            }

            return tempNodes;
        }

        public void Push(GenNode<T> newTail)//Append
        {
            if (size == 0)
            {
                SetTailHead(newTail);
            }
            else
            {
                tailNode.NextNode = newTail;//Since the new incoming node is our tail node, this will need to point to our new node
                tailNode = newTail;//the new node is the tail now
            }
            size++;
        }

        public void Pop()
        {

        }


        private void SetTailHead(GenNode<T> newTailHead)
        {
            headNode = newTailHead;
            tailNode = newTailHead;
       
        }

    }
}
