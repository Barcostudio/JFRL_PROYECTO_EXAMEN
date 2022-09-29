<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Calificaciones;
class CalificacionesController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $calis =Calificaciones::all();
        return $calis;
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $cali = new Calificaciones();
        $cali->alumno_id = $request->alumno_id;
        $cali->materia_id = $request->materia_id;
        $cali->p1 = $request->p1;
        $cali->p2 = $request->p2;
        $cali->p3 = $request->p3;
        $cali->cal = $request->cal;

        $cali->save();
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request)
    {
        $cali =Calificaciones::findOrFail($request->id);
        $cali->alumno_id = $request->alumno_id;
        $cali->materia_id = $request->materia_id;
        $cali->p1 = $request->p1;
        $cali->p2 = $request->p2;
        $cali->p3 = $request->p3;
        $cali->cal = $request->cal;

        $cali->save();

        return $cali;
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy(Request $request)
    {
        $cali =Calificaciones::destroy($request->id);
        return $cali;
    }
}
