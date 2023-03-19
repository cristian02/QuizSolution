// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const estudiante = {
    nombre: "María", 
    promedio: 10, 
    cursos: 3
}; 

console.table(estudiante); 
estudiante.habilitado = true; 
console.table(estudiante); 
//Object.freeze(estudiante); // no permite modificar los valores 
Object.seal(estudiante);  // permite modificar  vlaores
estudiante.cursos = 2020; 

console.table(estudiante); 

//map returna un arreglo nuevo vs foreach recorre los elementos del arreglo 

//SP puede retornar muchos o nada de valores 
//Function siempre retorna al menos un valor 
//SP es transaccional vs Function no es transactional 
//SP paametros de entrada y salida, Function solo salida 
