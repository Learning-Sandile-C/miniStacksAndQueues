using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    class GenNode<T>
    {
        private GenNode<T> nextNode, previousNode;
        private T nodeData;

        public GenNode(GenNode<T> previousNode, T nodeData, GenNode<T> nextNode)
        {
            this.NextNode = nextNode;
            this.PreviousNode = previousNode;
            this.NodeData = nodeData;
        }
        
        public GenNode(T content)
        {
            this.PreviousNode = null;
            this.NodeData = content;
            this.NextNode = null;
        }
        internal GenNode<T> NextNode { get => nextNode; set => nextNode = value; }
        internal GenNode<T> PreviousNode { get => previousNode; set => previousNode = value; }
        public T NodeData { get => nodeData; set => nodeData = value; }




    }
}
