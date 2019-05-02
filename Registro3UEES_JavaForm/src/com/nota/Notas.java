/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nota;

/**
 *
 * @author david
 */
public class Notas implements Operation{
    private double nota1;
    private double nota2;
    private double nota3;

    public Notas() 
    {
        
    }

    public Notas(double nota1, double nota2, double nota3, double dracer) {
        this.nota1 = nota1;
        this.nota2 = nota2;
        this.nota3 = nota3;
    }

    public double getNota1() {
        return nota1;
    }

    public void setNota1(double nota1) {
        this.nota1 = nota1;
    }

    public double getNota2() {
        return nota2;
    }

    public void setNota2(double nota2) {
        this.nota2 = nota2;
    }

    public double getNota3() {
        return nota3;
    }

    public void setNota3(double nota3) {
        this.nota3 = nota3;
    }


    @Override
    public double operation(double r1, double r2) {
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        double acum;
        double r3;
        acum = 6 - ((r1+r2)*0.3);
        r3 = acum/0.4;
        return r3;
    }
   
}
