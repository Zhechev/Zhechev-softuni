<p>В този блог са използвани: <b></б>HTML, CSS, JAVASCRIPT, JQUERY, PHP, MYSQL.</b></p>

<?php $this->title = 'Welcome to My Blog'; ?>

<h1><?=htmlspecialchars($this->title)?></h1>

<aside>
    <h2>Recent posts:</h2>
    <?php

    foreach ($this->postsSideBar as $post){ ?>
        <a href="<?=APP_ROOT?>/home/view/<?=$post['id']?>"><?=htmlentities($post['title'])?> </a>
    <?php } ?>
</aside>

<main>
    <?php

    foreach ($this->posts as $post){ ?>
        <div class="posts">
        <h1><?=htmlentities($post['title'])?> </h1>
        <p class="creator"><i>Posted on</i>
            <?=htmlentities($post['date'])?> <br />
            <i>by</i>
            <span><?=htmlentities($post['full_name'])?></span>
        </p>
        <p><?=($post['content'])?> </p>
        </div>
    <?php } ?>

</main>


