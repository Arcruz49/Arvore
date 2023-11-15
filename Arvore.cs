using System;
class Programm
{
    public class DoubleLinkedList
    {
        public int raiz;
        public DoubleLinkedList? direita;
        public DoubleLinkedList? esquerda;
        public DoubleLinkedList(int raiz, DoubleLinkedList? direita, DoubleLinkedList? esquerda)
        {
            this.raiz = raiz;
            this.direita = direita;
            this.esquerda = esquerda;
        }
        public void adicionaNumero(int n, DoubleLinkedList dl)
        {
            if (n > dl.raiz)
            {
                if (dl.direita == null)
                {
                    var d1 = new DoubleLinkedList(n, null, null);
                    dl.direita = d1;
                }
                else
                {
                    adicionaNumero(n, dl.direita);
                }
            }
            else
            {
                if (dl.esquerda == null)
                {
                    var d1 = new DoubleLinkedList(n, null, null);
                    dl.esquerda = d1;
                }
                else
                {
                    adicionaNumero(n, dl.esquerda);
                }
            }

        }
    }

    public static void printArvoreEmOrdem(DoubleLinkedList dl, int? cont = 0)
    {
        cont++;
        var text = '\t';

        if(dl.esquerda != null)
        {
            printArvoreEmOrdem(dl.esquerda,cont);
        }

        string n = new string (text, (int)cont);
        System.Console.WriteLine(@"{0}{1}",n,dl.raiz);

        if(dl.direita != null)
        {
            printArvoreEmOrdem(dl.direita,cont);
        } 
    }
}
