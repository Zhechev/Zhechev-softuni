<?php

class UsersController extends BaseController
{
    public function register()
    {
        if($this->isPost){
            $username = $_POST['username'];
            $password = $_POST['password'];
            $password_confirm = $_POST['password_confirm'];
            $full_name = $_POST['full_name'];
            if (strlen($username) <= 1){
                $this->setValidationError("username", "Username Invalid");

            }
            if (strlen($password) <= 1){
                $this->setValidationError("password", "Passowrd Invalid");
            }
            if ($password != $password_confirm){
                $this->setValidationError("password_confirm", "Passowrds do not match");
            }

            if ($this->formValid()) {
                $userId = $this->model->register($username, $password, $full_name);

                if ($userId != false) {
                    $_SESSION['username'] = $username;
                    $_SESSION['user_id'] = $userId;
                    $this->addInfoMessage("Registration successful!");
                    $this->redirect("");
                } else {
                    $this->addErrorMessage("Error: Registration failed!");
                }
            }
        }
    }

    public function login()
    {
        if($this->isPost){
            $username = $_POST['username'];
            $password = $_POST['password'];

            if (strlen($username) <= 1){
                $this->addErrorMessage("Username Invalid");
                return;
            }
            if (strlen($password) <= 1){
                $this->addErrorMessage("Passowrd Invalid");
                return;
            }

            $userId = $this->model->login($username, $password);

            if ($userId != false){
                $_SESSION['username'] = $username;
                $_SESSION['user_id'] = $userId;
                $this->addInfoMessage("Login successful!");
                $this->redirect("");
            }
            else {
                $this->addErrorMessage("Error: Login failed!");
            }
        }
    }

    public function logout()
    {
        session_destroy();
        $this->redirect("");
        var_dump($this);
    }

    public function index()
    {
        $this->authorize();
        $this->users = $this->model->getAll();
    }
}
