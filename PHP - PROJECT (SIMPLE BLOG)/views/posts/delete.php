<?php $this->title = 'Delete Post'; ?>

<h1>Are you sure you want to delete this post?</h1>

<form id="delPost" method="post">
    <label for=""title>Title:</label></br>
    <input type="text" id="title" value="<?=htmlspecialchars($this->post['title'])?>" disabled /></br>
    <label for="content">Content:</label></br>
    <textarea rows="10" id="content" disabled><?=
        htmlspecialchars($this->post['content'])?></textarea></br>
    <label for="date">Date:</label></br>
    <input type="text" id="date" value="<?= $this->post['date']?>" disabled /></br>
    <label for="authorID">Author ID:</label></br>
    <input type="text" id="authorID" value="<?=htmlspecialchars($this->post['user_id'])?>" disabled /></br>
    <div><a href="<?=APP_ROOT?>/posts">Cancel</a>
        <input type="submit" value="Delete" />
    </div>
</form>