import { NgModule } from '@angular/core';
import { LoginComponent } from './login/login.component';
import { AuthenticationRoutingModule } from './authentication-routing.module';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [LoginComponent],
  imports: [AuthenticationRoutingModule, ReactiveFormsModule]
})
export class AuthenticationModule {}
