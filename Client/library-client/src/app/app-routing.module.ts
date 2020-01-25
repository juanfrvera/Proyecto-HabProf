import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StartComponent } from './components/start/start.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';


const routes: Routes = [
  {
    path: 'inicio',
    component: StartComponent,
    data: {
      title: 'Inicio'
    }
  },
  {
    path: 'material/:id',
    loadChildren: () => import('./components/materials/materials.module').then(m => m.MaterialsModule),
    data: {
      title: 'Materiales'
    }
  },
  {
    path: 'materiales',
    loadChildren: () => import('./components/materials/materials.module').then(m => m.MaterialsModule),
    data: {
      title: 'Materiales'
    }
  },
  {
    path: '',
    redirectTo: '/inicio',
    pathMatch: 'full'
  },
  {
    path: '**',
    component: PageNotFoundComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
