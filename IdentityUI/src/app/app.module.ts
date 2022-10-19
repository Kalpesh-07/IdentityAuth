import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './login/login.component';
import { UserManagementComponent } from './user-management/user-management.component';
import { RegisterComponent } from './register/register.component';
import { AllUserManagementComponent } from './all-user-management/all-user-management.component';
import { AdminLayoutComponent } from './layout/admin-layout/admin-layout.component';
import { PublicLayoutComponent } from './layout/public-layout/public-layout.component';
import { AddUpdateArticleComponent } from './modal-components/add-update-article/add-update-article.component';
import { ConfirmModalComponent } from './modal-components/confirm-modal/confirm-modal.component';
import { AllArticleListPublicComponent } from './public-feature-module/all-article-list-public/all-article-list-public.component';
import { ArticleDetailComponent } from './public-feature-module/article-detail/article-detail.component';
import { ArticleManagementComponent } from './article-module/article-management/article-management.component';
import { BlockUiTemplateComponent } from './sharedModule/block-ui-template/block-ui-template.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BlockUIModule } from 'ng-block-ui';
import { ModalModule } from 'ngx-bootstrap/modal';
import { ToastrModule } from 'ngx-toastr';
// import { CKEditorModule } from '@ckeditor/ckeditor5-angular/ckeditor.module';
import { StripHtmlPipe } from './sharedModule/pipes/stripe-html.pipe';
import { TruncatePipe } from './sharedModule/pipes/truncate.pipe';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    UserManagementComponent,
    RegisterComponent,
    AllUserManagementComponent,
    AdminLayoutComponent,
    StripHtmlPipe,
    TruncatePipe,
    PublicLayoutComponent,
    AddUpdateArticleComponent,
    ConfirmModalComponent,
    AllArticleListPublicComponent,
    ArticleDetailComponent,
    ArticleManagementComponent,
    BlockUiTemplateComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    BlockUIModule.forRoot({
        template: BlockUiTemplateComponent
    }),
    ModalModule.forRoot(),
    // CKEditorModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
