import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import { Material } from 'src/app/models/material';

@Component({
  selector: 'app-material',
  templateUrl: './material.component.html',
  styleUrls: ['./material.component.scss']
})
export class MaterialComponent implements OnInit {
  private material: Material;
  private materials: Array<Material>;

  constructor(private router: Router, private route: ActivatedRoute) { }

  ngOnInit() {
    this.materials = new Array<Material>();
    this.materials.push(new Material(1, "Libro0", "Juan", "Mariquita Sanches de Fhonson", 50, 3));
    this.materials.push(new Material(2, "Libro2", "Tato", "Disney Cursed Line", 180, 2));

    // Check if the url has an id parameter, and if so, try to show the corresponding material
    let id = this.route.snapshot.paramMap.get("id");
    if (id != null) {
      let material: Material = this.materials.find(m => m.Id == Number.parseInt(id));
      if (material != null)
        this.showMaterial(material);
    }
  }

  private showMaterial(material: Material) {
    // Store in the variable so angular can interpolate the material properties in the view
    this.material = material;
  }

  private goBack() {
    // Take the id off of the url
    //this.location.replaceState("/materiales");
    this.router.navigate(["materiales"]);
  }
}
