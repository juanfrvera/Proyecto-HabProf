export class Material {
  private id: number;
  private titulo: string;
  private autor: string;
  private proveedor: string;
  private precio: number;
  private stock: number;

  // Constructors
  constructor(id: number, titulo: string, autor: string, proveedor: string, precio: number, stock: number) {
    this.id = id;
    this.titulo = titulo;
    this.autor = autor;
    this.proveedor = proveedor;
    this.precio = precio;
    this.stock = stock;
  }
  // Properties
  get Id(): number { return this.id; }

  get Titulo(): string { return this.titulo; }

  get Autor(): string { return this.autor; }

  get Proveedor(): string { return this.proveedor; }
  set Proveedor(value: string) { this.proveedor = value; }

  get Precio(): number { return this.precio; }

  get Stock(): number { return this.stock; }
}