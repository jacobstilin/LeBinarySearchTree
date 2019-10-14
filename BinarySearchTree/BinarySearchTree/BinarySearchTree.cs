using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public Node returnNode()
        {
            return root;
        }

        
        public void Add(int id)
        {
            Node newNode = new Node();
            newNode.item = id;

            if (root == null)
            {
                root = newNode;
            }

            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }


        public bool Search(int term)
        {
            bool result = RecursiveSearch(term, root);
            return result;
        }

        public bool RecursiveSearch(int term, Node middle)
        {
            if (term == middle.item)
            {
                return true;
            }

            else if (term < middle.item)
            {
                if (middle.left == null)
                {
                    return false;
                }
                
                else
                {
                    return RecursiveSearch(term, middle.left);
                }
            }
            else
            {
                if (middle.right == null)
                {
                    return false;
                }
                
                else
                {
                    return RecursiveSearch(term, middle.right);
                }
            }
        }
    }
}
