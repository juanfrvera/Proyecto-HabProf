import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MaterialsComponent } from './components/materials/materials.component';
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
    path: 'materiales/:id',
    component: MaterialsComponent,
    data: {
      title: 'Materiales'
    }
  },
  {
    path: 'materiales',
    component: MaterialsComponent,
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
