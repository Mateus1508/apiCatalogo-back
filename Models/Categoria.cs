﻿using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace apiCatalogo.Models;

public class Categoria
{
    public Categoria() { 
        Produtos = new Collection<Produto>();
    }

    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public string? ImageUrl { get; set; }

    public ICollection<Produto>? Produtos { get; set; }
}