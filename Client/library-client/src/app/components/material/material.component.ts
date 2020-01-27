import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import { Material } from '../../models/material';
import { MaterialService } from '../../services/materials/material.service';

@Component({
  selector: 'app-material',
  templateUrl: './material.component.html',
  styleUrls: ['./material.component.scss']
})
export class MaterialComponent implements OnInit {
  private material: Material;

  constructor(private router: Router, private route: ActivatedRoute, private materialService: MaterialService) { }

  ngOnInit() {
    // Check if the url has an id parameter, and if so, try to show the corresponding material
    let id = this.route.snapshot.paramMap.get("id");
    if (id != null) {
      this.materialService.getById(Number.parseInt(id)).subscribe(mat => {
        if (mat != null)
          this.showMaterial(mat);
      });
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
