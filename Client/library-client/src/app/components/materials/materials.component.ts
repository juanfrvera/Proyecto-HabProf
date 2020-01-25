import { Component, OnInit } from '@angular/core';
import { Material } from 'src/app/models/material';

@Component({
  selector: 'app-materials',
  templateUrl: './materials.component.html',
  styleUrls: ['./materials.component.scss']
})
export class MaterialsComponent implements OnInit {
  private materials: Array<Material>;

  ngOnInit() {
    this.materials = new Array<Material>(2);
    this.materials.push(new Material(1, "Libro0", "Juan", "Mariquita Sanches de Fhonson", 50, 3));
    this.materials.push(new Material(2, "Libro2", "Tato", "Disney Cursed Line", 180, 2));
  }
}
