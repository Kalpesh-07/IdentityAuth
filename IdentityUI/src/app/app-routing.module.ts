import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllUserManagementComponent } from './all-user-management/all-user-management.component';
import { ArticleManagementComponent } from './article-module/article-management/article-management.component';
import { AuthGuardService } from './guards/auth.service';
import { AdminLayoutComponent } from './layout/admin-layout/admin-layout.component';
import { PublicLayoutComponent } from './layout/public-layout/public-layout.component';
import { LoginComponent } from './login/login.component';
import { AllArticleListPublicComponent } from './public-feature-module/all-article-list-public/all-article-list-public.component';
import { ArticleDetailComponent } from './public-feature-module/article-detail/article-detail.component';
import { RegisterComponent } from './register/register.component';
import { UserManagementComponent } from './user-management/user-management.component';

const routes: Routes = [
  {
    path: "portal",component:AdminLayoutComponent,
    children: [
      { path: "user-management", component: UserManagementComponent, canActivate: [AuthGuardService] },
      { path: "all-user-management", component: AllUserManagementComponent, canActivate: [AuthGuardService] },
      { path: "article-management", component: ArticleManagementComponent, canActivate: [AuthGuardService] }
    ]
  },
 {
   path:"",component:PublicLayoutComponent,
   children:[
    {path: "" ,component:AllArticleListPublicComponent},
    {path: "article" ,component:ArticleDetailComponent},
    { path: "register", component: RegisterComponent },
    { path: "login", component: LoginComponent },
   ]
 },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
