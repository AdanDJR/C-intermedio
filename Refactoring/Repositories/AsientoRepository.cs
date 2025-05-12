// File: Repository/AsientoRepository.cs
using DBcontext;
using Entities;
using Interfaces;
using System.Collections.Generic;
using System.Linq;

public class AsientoRepository : IAsientoRepository
{
    private readonly ApplicationDbContext _context;

    public AsientoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Agregar(Asiento asiento)
    {
        _context.Asientos.Add(asiento);
        _context.SaveChanges();
    }

    public void Actualizar(Asiento asiento)
    {
        _context.Asientos.Update(asiento);
        _context.SaveChanges();
    }

    public void Remover(Asiento asiento)
    {
        _context.Asientos.Remove(asiento);
        _context.SaveChanges();
    }

    public List<Asiento> TraerTodos()
    {
        return _context.Asientos.ToList();
    }

    public Asiento ObtenerPorId(int asientoId)
    {
        return _context.Asientos.FirstOrDefault(a => a.AsientoId == asientoId);
    }
}

