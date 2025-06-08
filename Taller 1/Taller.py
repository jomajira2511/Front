import pandas as pd
import numpy as np
import seaborn as sns
import matplotlib.pyplot as plt
from sklearn.preprocessing import StandardScaler

# Cargar los archivos
saberpro_path = 'saberpro_2020.xlsx'
programas_path = 'programas_2020.xlsx'

saberpro_df = pd.read_excel(saberpro_path)
programas_df = pd.read_excel(programas_path)

# Inspeccionar saberpro
print("Inspección saberpro:")
print(saberpro_df.head())
print(saberpro_df.info())
print(saberpro_df.shape)

# Inspeccionar programas
print("\nInspección programas:")
print(programas_df.head())
print(programas_df.info())
print(programas_df.shape)

# Eliminar columnas que no aportan (por ejemplo, nombre, documento)
saberpro_df = saberpro_df.drop(columns=['TIPO_DOCUMENTO', 'NOMBRE', 'TIPO_EVALUADO', 'CIUDAD'])

# Unir con programas para tener el grupo de referencia
df_merged = pd.merge(saberpro_df, programas_df, on='COD_SNIES', how='left')

# Crear ID único por estudiante
df_merged['ID_ESTUDIANTE'] = df_merged.groupby(['COD_SNIES']).cumcount() + 1
df_merged['ID_ESTUDIANTE'] = df_merged['COD_SNIES'].astype(str) + '_' + df_merged['ID_ESTUDIANTE'].astype(str)

# Pivotear para tener un estudiante por fila y un módulo por columna
df_pivot = df_merged.pivot_table(index='ID_ESTUDIANTE',
                                 columns='MODULO',
                                 values='PUNTAJE_MODULO',
                                 aggfunc='first').reset_index()

# Unir con la columna de programa y grupo de referencia
info_estudiantes = df_merged[['ID_ESTUDIANTE', 'COD_SNIES', 'PROGRAMA', 'GRUPO_REFERENCIA']].drop_duplicates()
df_final = pd.merge(df_pivot, info_estudiantes, on='ID_ESTUDIANTE', how='left')

# Revisar nulos
print("\nValores nulos por columna:")
print(df_final.isnull().sum())

# Imputar nulos (opcional) o eliminar filas con nulos
df_final = df_final.dropna()

# Convertir columnas de módulos a numéricas
modulos = ['COMUNICACIÓN ESCRITA', 'LECTURA CRÍTICA', 'RAZONAMIENTO CUANTITATIVO',
           'COMPETENCIAS CIUDADANAS', 'INGLÉS']
for col in modulos:
    if col in df_final.columns:
        df_final[col] = pd.to_numeric(df_final[col], errors='coerce')

# Escalar datos
scaler = StandardScaler()
df_final[modulos] = scaler.fit_transform(df_final[modulos])

# Correlación
plt.figure(figsize=(8,6))
sns.heatmap(df_final[modulos].corr(), annot=True, cmap='coolwarm')
plt.title('Matriz de Correlación entre Módulos')
plt.tight_layout()
plt.show()

# Guardar archivo limpio
df_final.to_csv("saberpro_limpio.csv", index=False)
print("\nArchivo limpio guardado como 'saberpro_limpio.csv'")
