<?php $this->title = 'Login'; ?>

<h1><?= htmlspecialchars($this->title) ?></h1>

<form class="formLogin" method="post">
    <label for="registerUser">Username:<br/></label> <input type="text" name="username" /><br />
    <label for="passwordUser">Password:<br/></label> <input type="password" name="password" /><br />
    <input type="submit" value="Login" />


</form>