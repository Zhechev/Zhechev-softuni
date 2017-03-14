<?php $this->title = 'Edit Existing Post'; ?>

<h1><?= htmlspecialchars($this->title)?></h1>

<form id="editPost" method="post">
    <label for="titlee">Title:</label><br />
    <input type="text" id="titlee" name="post_title" value="<?=htmlspecialchars($this->post['title'])?>" required /><br />
    <label for="contentt">Content:</label><br />
    <textarea id="contentt" rows="10" name="post_content" required><?=htmlspecialchars($this->post['content'])?></textarea><br/>
    <label for="date">Date (yyyy-MM-dd hh:mm:ss):</label><br/>
    <input type="text" id="date" name="post_date" value="<?=htmlspecialchars($this->post['date'])?>" /><br/>
    <label for="authorID">Author ID:</label><br/>
    <input type="text" id="authorID" name="user_id" value="<?=htmlspecialchars($this->post['user_id'])?>" /><br/>
    <div><a href="<?=APP_ROOT?>/posts">Cancel</a>
        <input type="submit" value="Edit">

    </div>
</form>
