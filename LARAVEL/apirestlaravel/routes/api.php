<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

Route::middleware('auth:api')->get('/user', function (Request $request) {
    return $request->user();
});


Route::get('/alumnos', 'App\Http\Controllers\AlumnoController@index'); //muestra todos los registros
Route::post('/alumnos', 'App\Http\Controllers\AlumnoController@store'); // crea un registro
Route::put('/alumnos/{id}', 'App\Http\Controllers\AlumnoController@update'); // actualiza un registro
Route::delete('/alumnos/{id}', 'App\Http\Controllers\AlumnoController@destroy'); //elimina un registro

Route::get('/materia', 'App\Http\Controllers\MateriaController@index'); //muestra todos los registros
Route::post('/materia', 'App\Http\Controllers\MateriaController@store'); // crea un registro
Route::put('/materia/{id}', 'App\Http\Controllers\MateriaController@update'); // actualiza un registro
Route::delete('/materia/{id}', 'App\Http\Controllers\MateriaController@destroy'); //elimina un registro

Route::get('/calificaciones', 'App\Http\Controllers\CalificacionesController@index'); //muestra todos los registros
Route::post('/calificaciones', 'App\Http\Controllers\CalificacionesController@store'); // crea un registro
Route::put('/calificaciones/{id}', 'App\Http\Controllers\CalificacionesController@update'); // actualiza un registro
Route::delete('/calificaciones/{id}', 'App\Http\Controllers\CalificacionesController@destroy'); //elimina un registro
