﻿namespace RestApiModeloDDD.Domain.Entitys
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsAtive { get; set; }
    }
}