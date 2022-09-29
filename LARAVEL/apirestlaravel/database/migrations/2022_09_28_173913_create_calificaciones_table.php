<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('calificaciones', function (Blueprint $table) {
            $table->id();
            $table->unsignedBigInteger('alumno_id',20);
            $table->foreign('alumno_id')->references('id')->on('alumnos');
            $table->unsignedBigInteger('materia_id',20);
            $table->foreign('materia_id')->references('id')->on('materias');
            $table->integer('p1');
            $table->integer('p2');
            $table->integer('p3');
            $table->integer('cal');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('calificaciones');
    }
};
