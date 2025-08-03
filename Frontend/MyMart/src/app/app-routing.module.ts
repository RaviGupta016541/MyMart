import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductListComponent } from './features/products/product-list/product-list.component';

const routes: Routes = [
  // {path: '', redirectTo: '/products', pathMatch: 'full'},
  //{path: '/products', component: ProductListComponent},
  // {path: 'products', loadChildren: () => import('./features/products/product.module').then(m => m.ProductModule)},
  { path: '', redirectTo: 'products', pathMatch: 'full' },
  { path: 'products', component: ProductListComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
