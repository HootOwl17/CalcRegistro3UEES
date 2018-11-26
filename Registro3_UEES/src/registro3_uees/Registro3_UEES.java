
package registro3_uees;

import java.text.DecimalFormat;
import javax.swing.JOptionPane;

/**
 * Nombre Registro3_UEES
 * Version 1.0
 * Fecha 25/11/18
 * Copyright Dave Morz
 * @author David Morales
 */
public class Registro3_UEES {

    public static void main(String[] args) {
        double nota1,nota2,nota3;
        double prom,res;
        DecimalFormat df = new DecimalFormat("##.##");
        
        nota1 = Double.parseDouble(JOptionPane.showInputDialog("Ingrese nota de 1er Registro"));
        nota2 = Double.parseDouble(JOptionPane.showInputDialog("Ingrese nota de 2do Registro"));
        
        prom = (nota1+nota2)*0.3;
        res = 6 - prom;
        nota3 = res/0.4;
        
        JOptionPane.showMessageDialog(null, "Nesecita una nota de "+ df.format(nota3), "Tercer Registro", 1);
    }
    
}
