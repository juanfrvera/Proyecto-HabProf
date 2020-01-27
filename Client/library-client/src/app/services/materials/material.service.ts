import { Injectable } from '@angular/core';

import { Material } from '../../models/material';
import { of, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MaterialService {
  private materials: Array<Material>;

  private randomMaterial(id: number): Material {
    return new Material(id, "Libro" + id.toString(), "Autor", "Proveedor de prueba",
      Math.round(Math.random() * 100), Math.round(Math.random() * 10));
  }
  constructor() {
    this.materials = new Array<Material>();
    for (let i = 1; i <= 50; i++) {
      this.materials.push(this.randomMaterial(i));
    }
  }

  getAll(from: number = 1, to: number = null): Observable<Material[]> {
    if (to != null) {
      return of(this.materials.slice(from - 1, to));
    }
    else
      return of(this.materials.slice(from, this.materials.length));
  }
  getById(id: number): Observable<Material> {
    return of(this.materials.find(m => m.Id == id));
  }
  // The amount of materials
  count(): Observable<number> {
    return of(this.materials.length);
  }
}