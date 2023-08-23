class Calculadora {
    const double PI = 3.1416;
    private double elevarCuadrado(double num) {
        return num * num;
    }
    public double calcularAreaCirculo(double radio) {
        return PI * elevarCuadrado(radio);
    }
}

