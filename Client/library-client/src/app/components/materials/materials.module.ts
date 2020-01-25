import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

import { MaterialsComponent } from './materials.component';

const routes: Routes = [
  { path: '', component: MaterialsComponent },
  { path: ':id', component: MaterialsComponent }
];

@NgModule({
  declarations: [
    MaterialsComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
})
export class MaterialsModule { }