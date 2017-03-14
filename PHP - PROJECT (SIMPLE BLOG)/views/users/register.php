<?php $this->title = 'Register New User'; ?>

<h1><?= htmlspecialchars($this->title) ?></h1>

<form class="formRegister" method="post">
    <label for="loginUser">Username:<br /></label> <input type="text" name="username" /><br />
    <label for="loginUser">Passowrd::<br /></label> <input type="password" name="password" /><br />
    <label for="loginUser">Password confirm:<br /></label> <input type="password" name="password_confirm" /><br />
    <label for="loginUser">Full name:<br /></label> <input type="text" name="full_name" /><br />
    <input type="submit" value="Register" />


</form>
