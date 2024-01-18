using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadeBanco
{
    internal class ContaBanco
    {
        public int numconta;
        protected string tipo;
        private string dono;
        private float saldo;
        private bool status;

        //Método construtor
        public ContaBanco(int numconta, string tipo, string dono, float saldo, bool status)
        {
            this.numconta = numconta;
            this.tipo = tipo;
            this.dono = dono;
            this.saldo = 0;
            this.status = false;
        }

        //Métodos
        public void abrirConta(string t)
        {
            this.tipo = t;
            this.status = true;

            if (t == "CC")
            {
                this.saldo += 50;
            }
            else if (t == "CP")
            {
                this.saldo +=150;
            }
            else
            {
                Console.WriteLine("Conta Inválida");
            }
        }

        public void fecharConta()
        {
            if (saldo > 0)
            {
                Console.WriteLine("Conta com dinheiro");
            }
            else if (saldo < 0)
            {
                Console.WriteLine("Conta em débito");     
            }
            else
            {
                this.status = false;
            }
        }

        public void depositar(float v)
        {
            if (this.status == true)
            {
                this.saldo += v;
                Console.WriteLine($"Depósito realizado na conta de {this.dono}");
            }
            else
            {
                Console.WriteLine("Impossível depositar em uma conta fechada!");
            }
        }

        public void sacar(float v)
        {
            if (this.status == true)
            {
                if(saldo > 0)
                {
                    this.saldo -= v;
                    Console.WriteLine($"Saque realizado na conta de {this.dono}");
                }
                else
                {
                    Console.WriteLine($"Saldo insuficiente");
                }
            }
            else
            {
                Console.WriteLine("Impossível sacar em uma conta fechada!");
            }
        }

        public void pagarMensal()
        {
            float v = 0;

            if (this.tipo == "CC")
            {
                v = 12;
            }
            else if (this.tipo == "CP")
            {
                v = 20;
            }

            if (this.status == true)
            {
                if(saldo > 0)
                {
                    saldo -= v;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                }
            }
            else 
            { 
                Console.WriteLine("Impossível pagar"); 
            }
        }

        //Getters e Setters
        public int NumConta
        {
            get { return numconta; }
            set { numconta = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Dono
        {
            get { return dono; }
            set { dono = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
