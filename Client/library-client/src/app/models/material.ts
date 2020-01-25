export class Material {
  private id: number;
  private title: string;
  private author: string;
  private provider: string;
  private price: number;
  private stock: number;

  // Constructors
  constructor(id: number, title: string, author: string, provider: string, price: number, stock: number) {
    this.id = id;
    this.title = title;
    this.author = author;
    this.provider = provider;
    this.price = price;
    this.stock = stock;
  }
  // Properties
  get Id(): number { return this.id; }

  get Title(): string { return this.title; }

  get Author(): string { return this.author; }

  get Provider(): string { return this.provider; }
  set Provider(value: string) { this.provider = value; }

  get Price(): number { return this.price; }

  get Stock(): number { return this.stock; }
}