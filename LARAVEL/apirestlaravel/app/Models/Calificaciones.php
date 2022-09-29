<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Calificaciones extends Model
{
    use HasFactory;
    protected $fillable = ['alumno_id', 'materia_id', 'p1', 'p2', 'p3','cal'];
}
