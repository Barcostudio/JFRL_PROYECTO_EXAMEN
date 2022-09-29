﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIPRUEBAS.Models;
using System;
using Microsoft.AspNetCore.Cors;

namespace APIPRUEBAS.Controllers
{

    [EnableCors("ReglasCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class CalificacionesController : Controller
    {
        public readonly dbproyectoexamenContext _dbcontext;

        public CalificacionesController(dbproyectoexamenContext _context)
        {
            _dbcontext = _context;
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            List<Calificacione> lista = new List<Calificacione>();
            try
            {
                lista = _dbcontext.Calificaciones.ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = lista });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }

        [HttpGet]
        [Route("Obtener/{idCali:int}")]
        public IActionResult Obtener(int idCali)
        {
            Calificacione oCal = _dbcontext.Calificaciones.Find(idCali);
            if (oCal == null)
            {
                return BadRequest("Materia no encontrada");
            }

            try
            {
                oCal = _dbcontext.Calificaciones.Where(p => p.IdCali == idCali).FirstOrDefault();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = oCal });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = oCal });
            }
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Calificacione objeto)
        {
            try
            {
                _dbcontext.Calificaciones.Add(objeto);
                _dbcontext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpPut]
        [Route("Editar")]
        public IActionResult Editar([FromBody] Calificacione objeto)
        {

            Calificacione oCal = _dbcontext.Calificaciones.Find(objeto.IdCali);
            if (oCal == null)
            {
                return BadRequest("Calificacion no encontrada");
            }

            try
            {
                oCal.IdAlumno = objeto.IdAlumno;
                oCal.IdMateria = objeto.IdMateria;
                oCal.Pparcial = objeto.Pparcial;
                oCal.Sparcial = objeto.Sparcial;
                oCal.Tparcial = objeto.Tparcial;


                _dbcontext.Calificaciones.Update(oCal);
                _dbcontext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpDelete]
        [Route("Eliminar/{idCali:int}")]
        public IActionResult Eliminar(int idCali)
        {
            Calificacione oCal = _dbcontext.Calificaciones.Find(idCali);
            if (oCal == null)
            {
                return BadRequest("Materia no encontrada");
            }

            try
            {
                _dbcontext.Calificaciones.Remove(oCal);
                _dbcontext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }
    }
}
