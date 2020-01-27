import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';

import { MaterialService } from '../../services/materials/material.service';
import { Material } from './../../models/material';

@Component({
  selector: 'app-materials',
  templateUrl: './materials.component.html',
  styleUrls: ['./materials.component.scss']
})
export class MaterialsComponent implements OnInit {
  readonly pageSize: number = 15;

  private materials: Array<Material>;
  // The number of pages that will be displayed in the pagination
  private pages: Array<number>;

  private actualPage: number = 1;

  constructor(private router: Router, private materialService: MaterialService) { }

  ngOnInit() {
    this.loadMaterials(this.actualPage);
    this.materialService.count().subscribe(c => {
      let pageCount: number = Math.ceil(c / this.pageSize);
      this.pages = new Array<number>();
      for (let i = 1; i <= pageCount; i++) {
        this.pages.push(i);
      }
    });
  }

  // When a material of the list is clicked
  private materialClicked(material: Material) {
    this.router.navigate(["materiales", material.Id]);
  }

  private loadMaterials(page: number) {
    let start: number = (page - 1) * this.pageSize + 1;
    let end: number = page * this.pageSize;

    this.materialService.getAll(start, end).subscribe(materials => this.materials = materials);

    // Outside the suscribe, so we don't have to bind the method
    this.actualPage = page;
  }
  private prevPage() {
    if (this.actualPage > 1) {
      this.loadMaterials(this.actualPage - 1);
    }
  }
  private page(pageIndex: number) {
    if (pageIndex != this.actualPage) {
      this.loadMaterials(pageIndex);
    }
  }
  private nextPage() {
    if (this.actualPage < this.pages.length) {
      this.loadMaterials(this.actualPage + 1);
    }
  }
}