Empleado objEmpleado = new Empleado("Lionel Andrés", "Messi", 0, new BonoA(), new BonoPorResultado(), 100, new Gerente() );
Empleado objEmpleado2 = new Empleado("Cristiano", "Ronaldo", 1, new BonoFijo(), new BonoPorResultado(), 80, new Cadete() );

List<Empleado> empleados = new List<Empleado>();
empleados.Add(objEmpleado);
empleados.Add(objEmpleado2);

Empresa empresa = new Empresa("Microsoft", empleados);

empresa.ImprimirRecibos();


