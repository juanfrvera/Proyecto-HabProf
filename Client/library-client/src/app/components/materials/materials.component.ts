import { Component, OnInit, OnDestroy } from '@angular/core';
import { Material } from 'src/app/models/material';
import { Router } from '@angular/router';

@Component({
  selector: 'app-materials',
  templateUrl: './materials.component.html',
  styleUrls: ['./materials.component.scss']
})
export class MaterialsComponent implements OnInit {
  private materials: Array<Material>;

  constructor(private router: Router) { }

  ngOnInit() {
    this.materials = new Array<Material>();
    this.materials.push(new Material(1, "Libro0", "Juan", "Mariquita Sanches de Fhonson", 50, 3));
    this.materials.push(new Material(2, "Libro2", "Tato", "Disney Cursed Line", 180, 2));
  }

  // When a material of the list is clicked
  private materialClicked(material: Material) {
    //this.location.replaceState("/materiales/".concat(material.Id.toString()));
    this.router.navigate(["materiales", material.Id]);
  }
}