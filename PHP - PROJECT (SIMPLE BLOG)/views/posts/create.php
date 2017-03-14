<?php $this->title = 'Create New Post'; ?>

<h1><?=htmlspecialchars($this->title)?></h1>

<form id="formCreatePost" method="post">
    <label for="title">Title:</label><br />
    <input type="text" id="title" name="post_title" required /><br />
    <label for="content">Content:</label><br />
    <textarea id="content" rows="10" name="post_content" required></textarea><br />
    <div><a href="<?=APP_ROOT?>/posts">Cancel</a>
        <input type="submit" value="Create" />
    </div>
</form>




