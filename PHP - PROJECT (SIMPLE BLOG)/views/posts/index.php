<?php $this->title = 'Posts'; ?>

<a class="createLink" href="<?=APP_ROOT?>/posts/create">Create New</a>
<h1><?=htmlspecialchars($this->title)?></h1>


    <?php foreach ($this->posts as $post) : ?>
        <div class="postsDiv">
            <ul>
            <li><h2><?= htmlspecialchars($post['title']) ?></h2></li>
            <li><?= cutLongText($post['content']) ?><a href="<?=APP_ROOT?>/home/view/<?=$post['id']?>">..Show more</a></li><br />
            <li><?= htmlspecialchars($post['date']) ?></li><br />
                <li class="linkPosts"><a  href="<?=APP_ROOT?>/posts/edit/<?=$post['id']?> ">Edit</a><br/></li>  <li class="linkPosts"><a  href="<?=APP_ROOT?>/posts/delete/<?=$post['id']?> ">Delete</a></li>
            </ul>
        </div> <br/>
    <?php endforeach ?>
