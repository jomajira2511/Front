import pandas as pd

# Carga de archivos
saberpro = pd.read_excel("saberpro_2020.xlsx")
programas = pd.read_excel("programas_2020.xlsx")

# Inspección preliminar
print(saberpro.shape)
print(saberpro.info())
print(saberpro.head())

print(programas.shape)
print(programas.info())
print(programas.head())