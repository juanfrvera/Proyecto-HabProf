import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

import { MaterialsComponent } from './materials.component';
import { MaterialComponent } from 'src/app/components/material/material.component';

const routes: Routes = [
  { path: '', component: MaterialsComponent },
  { path: ':id', component: MaterialComponent }
];

@NgModule({
  declarations: [
    MaterialsComponent,
    MaterialComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
})
export class MaterialsModule {}