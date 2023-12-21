using System;
using System.Runtime.CompilerServices;
class Programm
{
    public class DoubleLinkedList
    {
        public int raiz;
        public DoubleLinkedList? direita;
        public DoubleLinkedList? esquerda;
        public static List<string> arvoreFormatada;
        public DoubleLinkedList(int raiz, DoubleLinkedList? direita, DoubleLinkedList? esquerda)
        {
            this.raiz = raiz;
            this.direita = direita;
            this.esquerda = esquerda;
            arvoreFormatada = new List<string>();
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
        public void ArvoreToString(DoubleLinkedList dl, int? cont = 0)
        {
            cont++;
            var text = '\t';

            if (dl.direita != null)
            {
                ArvoreToString(dl.direita, cont);
            }

            string n = new string(text, (int)cont);
            arvoreFormatada.Add(string.Format(@"{0}{1}", n, dl.raiz));


            if (dl.esquerda != null)
            {
                ArvoreToString(dl.esquerda, cont);
            }

        }
    }

    public static void printArvoreEmOrdem(DoubleLinkedList dl, int? cont = 0)
    {
        cont++;
        var text = '\t';

        if (dl.direita != null)
        {
            printArvoreEmOrdem(dl.direita, cont);
        }

        string n = new string(text, (int)cont - 1);
        System.Console.WriteLine(@"{0}{1}", n, dl.raiz);

        if (dl.esquerda != null)
        {
            printArvoreEmOrdem(dl.esquerda, cont);
        }
    }
    public static void Main(string[] args)
    {
        DoubleLinkedList d1 = new DoubleLinkedList(5, null, null);

        d1.adicionaNumero(7, d1);
        d1.adicionaNumero(6, d1);
        d1.adicionaNumero(8, d1);

        d1.adicionaNumero(2, d1);
        d1.adicionaNumero(3, d1);
        d1.adicionaNumero(0, d1);
        d1.adicionaNumero(10, d1);

        d1.ArvoreToString(d1);

        printArvoreEmOrdem(d1);
    }

}