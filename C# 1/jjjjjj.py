class Alumno():
    def __init__(self, nombre, nota):
        self.nombre = nombre
        self.nota = nota

    def printear(self):
        print(f"Alumno: {self.nombre}, Nota: {self.nota}")

    def aprobacion(self):
        try:
            if self.nota >=6:
                print(f"El alumno {self.nombre} esta APROBADO con un {self.nota}")
            else:
                print(f"El alumno {self.nombre} esta DESAPROBADO con un {self.nota}")
        except ValueError as err:
            print("Valor no valido. Intentelo nuevamente..")

franco = Alumno("Franco", 8)
franco.printear()
franco.aprobacion()