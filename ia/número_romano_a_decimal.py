import math

# -------------------------------
# Conversión de números romanos a decimal
# -------------------------------
def romano_a_decimal(romano: str) -> int:
    valores = {
        'I': 1, 'V': 5, 'X': 10,
        'L': 50, 'C': 100,
        'D': 500, 'M': 1000
    }
    total = 0
    i = 0
    while i < len(romano):
        if i + 1 < len(romano) and valores[romano[i]] < valores[romano[i + 1]]:
            total += valores[romano[i + 1]] - valores[romano[i]]
            i += 2
        else:
            total += valores[romano[i]]
            i += 1
    return total

# -------------------------------
# Clase Esfera
# -------------------------------
class Esfera:
    def __init__(self, radio: float):
        self.radio = radio

    def area_superficie(self) -> float:
        return 4 * math.pi * (self.radio ** 2)

    def volumen(self) -> float:
        return (4/3) * math.pi * (self.radio ** 3)

    def diametro(self) -> float:
        return 2 * self.radio

# -------------------------------
# Programa principal con entradas por consola
# -------------------------------
if __name__ == "__main__":
    # Conversión de número romano
    romano = input("Introduce un número romano: ").upper()
    decimal = romano_a_decimal(romano)
    print(f"El número romano {romano} equivale a {decimal} en decimal.")

    print("\n-------------------------------\n")

    # Cálculo de propiedades de la esfera
    try:
        radio = float(input("Introduce el radio de la esfera: "))
        esfera = Esfera(radio)
        print(f"Radio: {radio}")
        print(f"Área de la superficie: {esfera.area_superficie():.2f}")
        print(f"Volumen: {esfera.volumen():.2f}")
        print(f"Diámetro: {esfera.diametro():.2f}")
    except ValueError:
        print("Por favor introduce un número válido para el radio.")
